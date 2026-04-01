

// 1. Sukurkite naują projektą SchoolManagement;
// 2. Aprašykite abstrakčią klasę Person su FirstName, LastName, Birthday ir Email properties;
// 3. Aprašykite klasę Student, kuri paveldi Person. Pridėkite StudentId, Program, GPA ir EnrollmentYear properties;
// 4. Aprašykite klasę Staff, kuri paveldi Person. Pridėkite EmployeeId, Department, Salary ir HireDate properties;
// 5. Klasėje Person aprašykite abstraktų metodą GetRole(), kuris grąžina string. Perrašykite jį Student ir Staff klasėse;
// 6. Klasėje Person aprašykite abstraktų metodą GetProfile(). Perrašykite jį Student ir Staff klasėse — grąžinkite visas to objekto properties;
// 7. Klasėje Person aprašykite virtualų metodą GetContactInfo(), kuris grąžina Email. Perrašykite jį Staff klasėje — grąžinkite Email ir Department;
// 8. Klasėje Student aprašykite virtualų metodą GetAcademicStanding(), kuris pagal GPA reikšmę grąžina "Dean's List", "Good Standing", "Satisfactory" arba "Academic Probation";
// 9. Aprašykite klasę UndergraduateStudent, kuri paveldi Student. Pridėkite Major, Minor ir TotalCredits properties. Perrašykite GetRole() ir GetProfile() metodus;
// 10. Klasėje UndergraduateStudent perrašykite GetAcademicStanding() metodą — papildomai prie GPA įvertinimo pridėkite kurso pavadinimą ("Freshman", "Sophomore", "Junior", "Senior") pagal TotalCredits reikšmę;
// 11. Aprašykite klasę GraduateStudent, kuri paveldi Student. Pridėkite ThesisTitle, Supervisor ir ThesisSubmitted properties. Perrašykite GetRole(), GetProfile() ir GetAcademicStanding() metodus — magistrantams naudokite griežtesnius GPA kriterijus: "Distinction", "Merit", "Pass", "At Risk";
// 12. Aprašykite klasę Teacher, kuri paveldi Staff. Pridėkite SubjectArea, CoursesTaught (sąrašas) ir TeachingRating properties. Perrašykite GetRole() ir GetProfile() metodus;
// 13. Klasėje Staff aprašykite virtualų metodą CalculateAnnualBonus(), kuris grąžina decimal. Bazinis bonusas — 5% atlyginimo už kiekvierius 5 metus darbo stažo. Perrašykite jį Teacher klasėje — aukštą reitingą (>= 4.5) turintys dėstytojai gauna papildomą 10% bonusą;
// 14. Aprašykite klasę HeadOfDepartment, kuri paveldi Teacher. Pridėkite TeamSize ir DepartmentVision properties. Perrašykite GetRole(), GetProfile(), GetContactInfo() ir CalculateAnnualBonus() metodus — vadovai gauna papildomą 15% lyderystės bonusą;
// 15. Aprašykite klasę Administrator, kuri paveldi Staff. Pridėkite Office ir Responsibilities (sąrašas) properties. Perrašykite GetRole(), GetProfile() ir CalculateAnnualBonus() metodus — administratoriai gauna papildomą fiksuotą 500€ priedą;
// 16. Main metode sukurkite po vieną UndergraduateStudent, GraduateStudent, Teacher, HeadOfDepartment ir Administrator objektą su realistiškais duomenimis;
// 17. Main metode sukurkite List<Person> sąrašą, įdėkite visus sukurtus objektus ir cikle iškvieskite kiekvieno GetProfile() metodą;
// 18. Main metode sukurkite List<Staff> sąrašą, įdėkite Teacher, HeadOfDepartment ir Administrator objektus. Cikle atspausdinkite kiekvieno darbuotojo vardą, rolę ir apskaičiuotą metinį bonusą naudodami CalculateAnnualBonus();
// 19. Main metode sukurkite List<Student> sąrašą, įdėkite UndergraduateStudent ir GraduateStudent objektus. Cikle atspausdinkite kiekvieno studento vardą, GPA ir akademinę būklę naudodami GetAcademicStanding().



