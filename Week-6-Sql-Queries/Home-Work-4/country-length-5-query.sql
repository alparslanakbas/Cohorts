select count(*) as count_of_5_char_countries
from country
where length(country) = 5