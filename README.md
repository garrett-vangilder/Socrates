# Socrates

### Problem
During my former teaching career updating grades was difficult to do because of the poor UX implemented into most grading platforms. Students often were unable to accurately figure out their GPA due to the cumbersome UI. 

### Purpose

Socrates is an easy to use grade-book built using up-to-date technology and clean UI. It supports different roles and allows for teachers, students, parents, and administrators to access information quickly and efficiently. Socrates believes in convention before configuration, meaning that gradebooks must follow a certain format. This is intentional as it ensures that data is easy to access and easy to read for all parties involved in the education of today's youth.

### Solution

#### Roles and Points of Access 

1. There are three different roles: Administrators, Educators, and Parent/Student
1. Administrators are given access to the following actions: 
    * Create classes and assign teachers to classes
    * Create/Signup schools and edit school information
    * Create teacher and student accounts
    * Edit student information
    * Add and remove students from classes
    * View data for all classes
1. Educators are given access to the following actions: 
    * Edit class information
    * Add students to class roster
    * Delete students from class roster
    * Add assignments to gradebook
    * Apply a whole point value to each grade (see grade calculation section for more information)
    * Add, edit, and delete grades for each assignment
    * View data for all classes assigned to them
1. Parent/Students are given access to the following actions: 
    * View grades for all assignments in all assigned classes
    * Message teachers or administrators through built in messaging system
    * View personal data (Specifically a line graph showing GPA over time)

#### Grade Calculation

All grades are calculated in the following fashion:

1. There are four types of grades: Major Assessments, Minor Assessments, Homework, Daily/Participation Grades 
1. Grade types are given a percentage value to assess the final grade for each class. This is decided by the teacher.
1. All individual assignments are given a total point value and assigned to a grade type. This is the grading convention used by every single Socrates grading platform.

### Technologies Used

Angular 2.x | .NET Core | Identity Framework | SQLite | Bootstrap 4 | Entity Framework 


#### Resources

Blog Post about .NET CORE | Angular 2 | TypeScript 2 : [Here!](http://blog.stevensanderson.com/2016/10/04/angular2-template-for-visual-studio/)