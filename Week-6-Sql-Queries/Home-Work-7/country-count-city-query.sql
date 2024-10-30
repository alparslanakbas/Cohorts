Select country_id, count(*) as count_city
from city
group by country_id
order by count_city desc
limit 1
