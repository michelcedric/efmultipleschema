# efmultipleschema

![multiple](MultipleSchema.PNG)

dotnet tool install --global dotnet-ef

dotnet ef migrations add AddStudent

dotnet ef database update

dotnet ef migrations add AddCourse

dotnet ef database update