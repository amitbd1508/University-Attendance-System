
Create  Procedure tblCTGetAllStudentByCourseAndTeachersID
(
	@TeacherID varchar(max) = null,
	@CourseCode varchar(max) = null
)
As
Begin
	Select * from tblCourseTaken where TeacherID=@TeacherID and CourseCode=@CourseCode; 
End