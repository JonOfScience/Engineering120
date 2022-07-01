echo "This is a hello world batch file"
if(Get-Item -Path FolderA -ErrorAction Ignore) {
	echo "Folder already exists"
}
else {
	echo "Creating folder"
	md FolderA
}
cd FolderA
echo "Hello world" > testfile.txt
echo "Hope you're cool" >> testfile.txt
echo Another Line Without Quotes >> testfile.txt
echo "File contents after appending text"
cat testfile.txt
echo "Adding Content" > testfile.txt
echo "File after writing over"
cat testfile.txt

cd ..