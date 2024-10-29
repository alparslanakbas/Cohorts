select country from country 
where length (country) >=6
	and country like '%n'
order by country asc