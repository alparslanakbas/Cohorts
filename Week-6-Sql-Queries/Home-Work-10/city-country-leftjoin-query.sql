Select city.city as city_name, country.country as country_name
from city
left join country on city.country_id = country.country_id