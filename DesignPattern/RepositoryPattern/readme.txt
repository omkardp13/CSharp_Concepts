1.The design pattern to separate the data access layer from the application
2.Providing interface without exposing implementation 
3.Helps to create abstraction
4.Previously the controller who is directly talking to the database using that dbContext--->Wrong Practice

                     Repository                    
Controller --->      --------                -----> Database
                     --------
                     --------
5.Repositories can be added in between the controller and the database so that all the operations on the databse is then handled by repository.
6.The DbContext class is injected inside the repository rather than inside the controller and the repository that then inject the controller.
By doing that controller has no awareness of what's being called through the dbContect,whether it is SQL Server or MongoDb it has no idea about it.

Benifits--->
1.Decoupling
2.Consistency
3.Performance
4.Multiple Data Sources(Switching)
7.This is decoupling the data access layer from rest of the application.
