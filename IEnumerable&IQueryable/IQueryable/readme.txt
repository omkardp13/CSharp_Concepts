1.Namespace: System.Linq

2.When to Use: When working with remote, queryable data sources like a database (e.g., Entity Framework). IQueryable allows querying and filtering data at the database level.

3.Execution: Deferred execution at the database level. This means that only the necessary data is fetched based on the query, improving performance.

4.Best For: Scenarios involving large datasets or complex queries where you want to minimize the data brought into memory.

5.IQueryable<Product> lets Entity Framework convert the Where clause into SQL, so the filtering is done in the database rather than in memory.

6.Execution is deferred until ToListAsync is called, at which point the SQL query is sent to the database and retrieves only the necessary data.
