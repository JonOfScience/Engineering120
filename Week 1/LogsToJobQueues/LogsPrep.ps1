<#
 # Mock log files
#>

if(Get-Item -Path logs -ErrorAction Ignore) {
	echo "Logs folder exists"
}
else {
	echo "Creating logs folder"
	md logs
}

echo "Building log files"
echo "This is the contents of log file 1" > ./logs/log1.log
echo "This is the contents of log file 2" > ./logs/log2.log
echo "FileError: File does not exist" >> ./logs/log1.log
echo "ServerError: Connection TimeOut" >> ./logs/log1.log
echo "ServerError: Connection failed" >> ./logs/log2.log
echo "Log files built"