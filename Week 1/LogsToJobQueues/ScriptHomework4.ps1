# Information on Leader Names and their responsibilities (TODO -> file)
$teamleaders = @("Bob", "Sally")
$matchtext = @("FileError", "ServerError")

# Build queue file names from Team Leader names
$teamleaderqueues = @()
foreach ($leadername in $teamleaders) {
    $teamleaderqueues += $leadername + "-JobsQueue.txt"
}

# Check if queue files exist. If not, create a new one with a header
foreach ($file in $teamleaderqueues) {
    if(Get-Item -Path $file -ErrorAction Ignore) {
    	Write-Host "Team Leader Queue Exists -> " $file
    }
    else {
	    Write-Host "Creating Team Leader Queue -> " $file 
        echo $file > $file
        echo "==========" >> $file
    }
}

# Create an array to hold reporting metrics
$teamleadercounts = @(0) * $teamleaderqueues.Count

# For each file in the ./logs directory
foreach ($file in get-childitem ./logs/*.log -file)
{
    Write-Host "Reading -> " -NoNewline
    Write-Host $file -ForegroundColor Cyan
    foreach ($line in Get-Content $file) {
        # for each Team Leader listed
        for ($counter = 0; $counter -lt $teamleaderqueues.Count; $counter++) {
            # check each line for their matching text
            if($line -match $matchtext[$counter]) {
                # put those lines into the correct job queue for distribution
                echo $line >> $teamleaderqueues[$counter]
                $teamleadercounts[$counter]++
                }
            }
        }
    # remove the scanned logs (so you don't scan twice)
    rm $file
}

# output reporting metrics
for ($idx = 0; $idx -lt $teamleadercounts.Count; $idx++) {
    Write-Host $teamleaderqueues[$idx].ToString() "has had" $teamleadercounts[$idx].ToString() "jobs added."
}
