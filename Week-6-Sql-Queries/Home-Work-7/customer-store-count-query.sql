Select store_id, count(*) as count_customer_store
from customer
group by store_id 