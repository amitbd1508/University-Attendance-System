update tblCourseTaken 
set AttendanceCounter=(1-(select AttendanceCounter 
						from tblCourseTaken where StudentID='011132134' and CourseCode='CSI322') ) 
where StudentID='011132134' and CourseCode='CSI322';