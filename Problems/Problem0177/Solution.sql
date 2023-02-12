SELECT TOP 1 sr.salary AS SecondHighestSalary
FROM (VALUES (2)) AS r(rank)
LEFT JOIN
(
    SELECT
        DENSE_RANK() OVER(ORDER BY salary DESC) AS rank,
        salary
    FROM Employee
) AS sr ON sr.rank = r.rank