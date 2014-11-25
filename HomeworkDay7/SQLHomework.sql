select * from Customers where state = 'New York'
select * from Customers where Email like '%.org'
select * from Orders o where o.OrderDate between '8/1/2010' and '8/31/2010'
select top 5 * from orders o
where o.Fulfilled = 0
order by OrderAmount desc

select c.LastName, o.OrderDate, c.CreditLimit, o.OrderAmount from Customers c
inner join orders o on o.CustomerID = c.CustomerID
where o.OrderAmount > c.CreditLimit