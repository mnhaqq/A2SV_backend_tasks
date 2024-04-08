-- Write your PostgreSQL query statement below
SELECT sub.name as Employee FROM Employee manager
JOIN Employee sub ON manager.id = sub.managerId
WHERE sub.salary > manager.salary