Select count(*) as big_rental_rage_count
from film
where rental_rate = (select max(rental_rate) from film)