select * from film 
where rental_rate = 0.99 
and (replacement_cost = 12.99 or replacement_cost = 28.99) 
order by rental_rate asc, replacement_cost asc