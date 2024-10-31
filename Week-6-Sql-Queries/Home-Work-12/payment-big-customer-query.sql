Select customer_id, count(*) as big_payment_customer
from payment
group by customer_id
order by big_payment_customer desc