-- Write your PostgreSQL query statement below
SELECT name as Customers FROM Customers c
LEFT JOIN Orders on c.id = Orders.customerId
WHERE Orders.id is NULL