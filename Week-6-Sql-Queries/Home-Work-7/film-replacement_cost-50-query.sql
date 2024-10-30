Select replacement_cost, count(*) as count_replacement_cost
from film
group by replacement_cost
having count(*) >= 50