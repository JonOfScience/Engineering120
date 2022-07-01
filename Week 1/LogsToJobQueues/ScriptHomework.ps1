echo "Building log files"
echo "This is the contents of log file 1" > log1.log
echo "This is the contents of log file 2" > log2.log
echo "This is an event happening" >> log2.log
echo "Log files built"
echo "Compiled log" > base.log
cat log1.log >> base.log
cat log2.log >> base.log
rm log1.log
rm log2.log