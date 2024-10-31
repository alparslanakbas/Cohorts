(Select first_name from actor
order by first_name)
intersect
(select first_name from customer
order by first_name)