using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Products
{
    // alttaki ProductDto, ProductService ve IProductService ile birlikte kullanilacak olan DTO (Data Transfer Object) sinifidir. Primary constructor ile tanimlanmistir.
    public record ProductDto(int Id,
        string Name,
        decimal Price,
        int Stock
    );



    #region Comments- Record and init

    //record kullanmistik bu sayede verileri daha dogru sekilde karsilastirmis oluyorduk.
    //public record ProductDto
    //{
    //    // init yapmak -> sadece nesne oluşturulurken değer atamasına izin verir, sonrasında değiştirilemez.
    //    public int Id { get; init; }
    //    public string Name { get; init; }

    //    public decimal Price { get; init; }

    //    public int Stock { get; init; }
    //    // Additional properties can be added as needed
    //}

    #endregion

}
