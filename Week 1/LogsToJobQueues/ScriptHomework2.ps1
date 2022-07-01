echo "Building log files"
echo "This is the contents of log file 1" > log1.log
echo "This is the contents of log file 2" > log2.log
echo "This is an event happening" >> log2.log
echo "Log files built"
echo "Compiled log" > ResultLog.txt
foreach ($file in get-childitem *.log -file)
{
 cat $file >> ResultLog.txt
 rm $file
}