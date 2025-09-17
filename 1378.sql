SELECT uni.unique_id AS unique_id, em.name AS name
FROM Employees em
LEFT JOIN EmployeeUNI uni
ON em.id = uni.id