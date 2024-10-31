Select count(*) as films_avg
from film
where length > (select avg(length) from film)