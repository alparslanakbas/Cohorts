Select payment.payment_id, customer.first_name, customer.last_name
from payment
inner join customer on payment.customer_id = customer.customer_id