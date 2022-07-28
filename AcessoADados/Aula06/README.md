## Aula 06
- Model
- Migrations: https://docs.microsoft.com/en-us/learn/modules/persist-data-ef-core/ 
- Validação de Modelos : https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0


```java
public class Person
{
    [Required(ErrorMessage = "Please enter a name.")]
    public string Name { get; set; }

    [Range(0, 150)]
    public int Age { get; set; }

    [Required]
    [RegularExpression(".+\\@.+\\..+")]
    public string EmailAddress { get; set; }

    [DataType(DataType.MultilineText)]
    [StringLength(20)]
    public string Description { get; set; }
}

```




- Data Annotation: https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-6.0
- Migrando para o SQLServer
