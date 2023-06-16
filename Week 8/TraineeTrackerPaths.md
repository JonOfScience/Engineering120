
# Pathing

```mermaid
graph LR
login[Login]
index[Index]
login --> index

edittrainee[Edit Trainee]
traineedetails[Trainee Details]
deletetrainee[Delete Trainee]
edittrainer[Trainer Details]
trainerdetails[Trainer Details]
deletetrainer[Trainer Delete]
editcourse[Edit Course]
coursedetails[Course Details]
deletecourse[Delete Course]

index --> edittrainee
index --> traineedetails
index --> deletetrainee
index --> edittrainer
index --> trainerdetails
index --> deletetrainer
index --> editcourse
index --> coursedetails
index --> deletecourse

edittrainee --> index
traineedetails --> edittrainee
traineedetails --> index

edittrainer --> index
edittrainer --> traineesoncourse[Trainees on Course]
traineesoncourse --> traineesoncourse

```

Filters
index --> trainees
index --> trainers
index --> courses
index --> account

Click on a tab twice and it hides -> Can end up with empty page (Indicators)

Edit Trainee: Return to index link breaks page
Details: Back to list breaks index page
Courses 
