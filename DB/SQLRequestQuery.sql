CREATE PROCEDURE [dbo].[Faculty_Subjekt_Teacher]  
    AS  
	BEGIN
       SELECT s.SubjektName ,f.FacultyName,t.TeacherName
		From Subjekt s, Teacher t, Faculty f 
		WHERE s.FacultyID = f.FacultyID AND s.TeacherID = t.TeacherID
		ORDER BY f.FacultyID asc;
    END  