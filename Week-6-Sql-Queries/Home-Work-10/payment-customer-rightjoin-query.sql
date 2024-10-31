Select payment.payment_id, customer.first_name, customer.last_name
from customer
right join payment on payment.customer_id = customer.customer_id
