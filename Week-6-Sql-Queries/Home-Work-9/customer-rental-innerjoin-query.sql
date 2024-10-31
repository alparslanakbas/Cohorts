Select rental.rental_id, customer.first_name, customer.last_name
from rental
inner join customer on rental.customer_id = customer.customer_id
