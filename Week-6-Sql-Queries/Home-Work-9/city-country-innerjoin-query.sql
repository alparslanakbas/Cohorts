Select country.country, city.city as city_name
from city
inner join country on city.country_id = country.country_id
order by country.country_id asc