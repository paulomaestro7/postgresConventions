docker run --name some-postgres -p 5432:5432 -e POSTGRES_PASSWORD=1234@1234! -d postgres

docker run -p 8080:80 --link some-postgres -e 'PGADMIN_DEFAULT_EMAIL=paulo@paulo.com' -e 'PGADMIN_DEFAULT_PASSWORD=1234' -d dpage/pgadmin4

https://www.npgsql.org/efcore/modeling/table-column-naming.html

https://github.com/efcore/EFCore.NamingConventions

