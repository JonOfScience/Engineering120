/*
DROP TABLE IF EXISTS courses;

CREATE TABLE courses (
	course_id INT PRIMARY KEY IDENTITY,
	course_name VARCHAR(20) UNIQUE
);

INSERT INTO courses 
	( course_name )
VALUES
('C# Development'),
('Java Development'),
('Data Engineering');
*/


DROP TABLE IF EXISTS students;
CREATE TABLE students (
	student_id INT PRIMARY KEY IDENTITY(1, 1),
	student_name VARCHAR(20),
	course_id INT FOREIGN KEY REFERENCES courses (course_id)
);

INSERT INTO students
(student_name, course_id)
VALUES
('Alice', 1),
('Bob', 1),
('Charlie', 2),
('David', 5);