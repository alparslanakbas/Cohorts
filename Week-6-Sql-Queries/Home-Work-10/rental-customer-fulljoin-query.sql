Select rental.rental_id, customer.first_name, customer.last_name
from customer
full join rental on rental.customer_id = customer.customer_id