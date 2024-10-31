select title 
from film
where rental_rate = (select min(rental_rate) from film)
and replacement_cost = (select min(replacement_cost) from film)