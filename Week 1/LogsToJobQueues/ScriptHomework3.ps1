echo "Building log files"
echo "This is the contents of log file 1" > log1.log
echo "This is the contents of log file 2" > log2.log
echo "FileError: File does not exist" >> log1.log
echo "This is an event happening" >> log2.log
echo "Log files built"

echo "Compiled log" > ResultLog.txt
foreach ($file in get-childitem *.log -file)
{
 foreach ($line in Get-Content $file) {
    if($line -match "event") {
        echo $line >> ResultLog.txt
        }
    }
    rm $file
}
cat ResultLog.txt