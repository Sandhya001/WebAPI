using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AlbumsController : ApiController
    {
        Albums[] album = new Albums[]
        {

  new Albums {
    userId= 1,
    id= 1,
    title= "quidem molestiae enim"
  },
  new Albums {
    userId= 1,
    id= 2,
    title= "sunt qui excepturi placeat culpa"
  },
  new Albums {
    userId= 1,
    id= 3,
    title= "omnis laborum odio"
  },
  new Albums {
    userId= 1,
    id= 4,
    title= "non esse culpa molestiae omnis sed optio"
  },
  new Albums {
    userId= 1,
    id= 5,
    title= "eaque aut omnis a"
  },
  new Albums {
    userId= 1,
    id= 6,
    title= "natus impedit quibusdam illo est"
  },
  new Albums {
    userId= 1,
    id= 7,
    title= "quibusdam autem aliquid et et quia"
  },
  new Albums {
    userId= 1,
    id= 8,
    title= "qui fuga est a eum"
  },
  new Albums {
    userId= 1,
    id= 9,
    title= "saepe unde necessitatibus rem"
  },
  new Albums {
    userId= 1,
    id= 10,
    title= "distinctio laborum qui"
  },
  new Albums {
    userId= 2,
    id= 11,
    title= "quam nostrum impedit mollitia quod et dolor"
  },
  new Albums {
    userId= 2,
    id= 12,
    title= "consequatur autem doloribus natus consectetur"
  },
  new Albums {
    userId= 2,
    id= 13,
    title= "ab rerum non rerum consequatur ut ea unde"
  },
  new Albums {
    userId= 2,
    id= 14,
    title= "ducimus molestias eos animi atque nihil"
  },
  new Albums {
    userId= 2,
    id= 15,
    title= "ut pariatur rerum ipsum natus repellendus praesentium"
  },
  new Albums {
    userId= 2,
    id= 16,
    title= "voluptatem aut maxime inventore autem magnam atque repellat"
  },
  new Albums {
    userId= 2,
    id= 17,
    title= "aut minima voluptatem ut velit"
  },
  new Albums {
    userId= 2,
    id= 18,
    title= "nesciunt quia et doloremque"
  },
  new Albums {
    userId= 2,
    id= 19,
    title= "velit pariatur quaerat similique libero omnis quia"
  },
  new Albums {
    userId= 2,
    id= 20,
    title= "voluptas rerum iure ut enim"
  },
  new Albums {
    userId= 3,
    id= 21,
    title= "repudiandae voluptatem optio est consequatur rem in temporibus et"
  },
  new Albums {
    userId= 3,
    id= 22,
    title= "et rem non provident vel ut"
  },
  new Albums {
    userId= 3,
    id= 23,
    title= "incidunt quisquam hic adipisci sequi"
  },
  new Albums {
    userId= 3,
    id= 24,
    title= "dolores ut et facere placeat"
  },
  new Albums {
    userId= 3,
    id= 25,
    title= "vero maxime id possimus sunt neque et consequatur"
  },
  new Albums {
    userId= 3,
    id= 26,
    title= "quibusdam saepe ipsa vel harum"
  },
  new Albums {
    userId= 3,
    id= 27,
    title= "id non nostrum expedita"
  },
  new Albums {
    userId= 3,
    id= 28,
    title= "omnis neque exercitationem sed dolor atque maxime aut cum"
  },
  new Albums {
    userId= 3,
    id= 29,
    title= "inventore ut quasi magnam itaque est fugit"
  },
  new Albums {
    userId= 3,
    id= 30,
    title= "tempora assumenda et similique odit distinctio error"
  },
  new Albums {
    userId= 4,
    id= 31,
    title= "adipisci laborum fuga laboriosam"
  },
  new Albums {
    userId= 4,
    id= 32,
    title= "reiciendis dolores a ut qui debitis non quo labore"
  },
  new Albums {
    userId= 4,
    id= 33,
    title= "iste eos nostrum"
  },
  new Albums {
    userId= 4,
    id= 34,
    title= "cumque voluptatibus rerum architecto blanditiis"
  },
  new Albums {
    userId= 4,
    id= 35,
    title= "et impedit nisi quae magni necessitatibus sed aut pariatur"
  },
  new Albums {
    userId= 4,
    id= 36,
    title= "nihil cupiditate voluptate neque"
  },
  new Albums {
    userId= 4,
    id= 37,
    title= "est placeat dicta ut nisi rerum iste"
  },
  new Albums {
    userId= 4,
    id= 38,
    title= "unde a sequi id"
  },
  new Albums {
    userId= 4,
    id= 39,
    title= "ratione porro illum labore eum aperiam sed"
  },
  new Albums {
    userId= 4,
    id= 40,
    title= "voluptas neque et sint aut quo odit"
  },
  new Albums {
    userId= 5,
    id= 41,
    title= "ea voluptates maiores eos accusantium officiis tempore mollitia consequatur"
  },
  new Albums {
    userId= 5,
    id= 42,
    title= "tenetur explicabo ea"
  },
  new Albums {
    userId= 5,
    id= 43,
    title= "aperiam doloremque nihil"
  },
  new Albums {
    userId= 5,
    id= 44,
    title= "sapiente cum numquam officia consequatur vel natus quos suscipit"
  },
  new Albums {
    userId= 5,
    id= 45,
    title= "tenetur quos ea unde est enim corrupti qui"
  },
  new Albums {
    userId= 5,
    id= 46,
    title= "molestiae voluptate non"
  },
  new Albums {
    userId= 5,
    id= 47,
    title= "temporibus molestiae aut"
  },
  new Albums {
    userId= 5,
    id= 48,
    title= "modi consequatur culpa aut quam soluta alias perspiciatis laudantium"
  },
  new Albums {
    userId= 5,
    id= 49,
    title= "ut aut vero repudiandae voluptas ullam voluptas at consequatur"
  },
  new Albums {
    userId= 5,
    id= 50,
    title= "sed qui sed quas sit ducimus dolor"
  },
  new Albums {
    userId= 6,
    id= 51,
    title= "odit laboriosam sint quia cupiditate animi quis"
  },
  new Albums {
    userId= 6,
    id= 52,
    title= "necessitatibus quas et sunt at voluptatem"
  },
  new Albums {
    userId= 6,
    id= 53,
    title= "est vel sequi voluptatem nemo quam molestiae modi enim"
  },
  new Albums {
    userId= 6,
    id= 54,
    title= "aut non illo amet perferendis"
  },
  new Albums {
    userId= 6,
    id= 55,
    title= "qui culpa itaque omnis in nesciunt architecto error"
  },
  new Albums {
    userId= 6,
    id= 56,
    title= "omnis qui maiores tempora officiis omnis rerum sed repellat"
  },
  new Albums {
    userId= 6,
    id= 57,
    title= "libero excepturi voluptatem est architecto quae voluptatum officia tempora"
  },
  new Albums {
    userId= 6,
    id= 58,
    title= "nulla illo consequatur aspernatur veritatis aut error delectus et"
  },
  new Albums {
    userId= 6,
    id= 59,
    title= "eligendi similique provident nihil"
  },
  new Albums {
    userId= 6,
    id= 60,
    title= "omnis mollitia sunt aliquid eum consequatur fugit minus laudantium"
  },
  new Albums {
    userId= 7,
    id= 61,
    title= "delectus iusto et"
  },
  new Albums {
    userId= 7,
    id= 62,
    title= "eos ea non recusandae iste ut quasi"
  },
  new Albums {
    userId= 7,
    id= 63,
    title= "velit est quam"
  },
  new Albums {
    userId= 7,
    id= 64,
    title= "autem voluptatem amet iure quae"
  },
  new Albums {
    userId= 7,
    id= 65,
    title= "voluptates delectus iure iste qui"
  },
  new Albums {
    userId= 7,
    id= 66,
    title= "velit sed quia dolor dolores delectus"
  },
  new Albums {
    userId= 7,
    id= 67,
    title= "ad voluptas nostrum et nihil"
  },
  new Albums {
    userId= 7,
    id= 68,
    title= "qui quasi nihil aut voluptatum sit dolore minima"
  },
  new Albums {
    userId= 7,
    id= 69,
    title= "qui aut est"
  },
  new Albums {
    userId= 7,
    id= 70,
    title= "et deleniti unde"
  },
  new Albums {
    userId= 8,
    id= 71,
    title= "et vel corporis"
  },
  new Albums {
    userId= 8,
    id= 72,
    title= "unde exercitationem ut"
  },
  new Albums {
    userId= 8,
    id= 73,
    title= "quos omnis officia"
  },
  new Albums {
    userId= 8,
    id= 74,
    title= "quia est eius vitae dolor"
  },
  new Albums {
    userId= 8,
    id= 75,
    title= "aut quia expedita non"
  },
  new Albums {
    userId= 8,
    id= 76,
    title= "dolorem magnam facere itaque ut reprehenderit tenetur corrupti"
  },
  new Albums {
    userId= 8,
    id= 77,
    title= "cupiditate sapiente maiores iusto ducimus cum excepturi veritatis quia"
  },
  new Albums {
    userId= 8,
    id= 78,
    title= "est minima eius possimus ea ratione velit et"
  },
  new Albums {
    userId= 8,
    id= 79,
    title= "ipsa quae voluptas natus ut suscipit soluta quia quidem"
  },
  new Albums {
    userId= 8,
    id= 80,
    title= "id nihil reprehenderit"
  },
  new Albums {
    userId= 9,
    id= 81,
    title= "quibusdam sapiente et"
  },
  new Albums {
    userId= 9,
    id= 82,
    title= "recusandae consequatur vel amet unde"
  },
  new Albums {
    userId= 9,
    id= 83,
    title= "aperiam odio fugiat"
  },
  new Albums {
    userId= 9,
    id= 84,
    title= "est et at eos expedita"
  },
  new Albums {
    userId= 9,
    id= 85,
    title= "qui voluptatem consequatur aut ab quis temporibus praesentium"
  },
  new Albums {
    userId= 9,
    id= 86,
    title= "eligendi mollitia alias aspernatur vel ut iusto"
  },
  new Albums {
    userId= 9,
    id= 87,
    title= "aut aut architecto"
  },
  new Albums {
    userId= 9,
    id= 88,
    title= "quas perspiciatis optio"
  },
  new Albums {
    userId= 9,
    id= 89,
    title= "sit optio id voluptatem est eum et"
  },
  new Albums {
    userId= 9,
    id= 90,
    title= "est vel dignissimos"
  },
  new Albums {
    userId= 10,
    id= 91,
    title= "repellendus praesentium debitis officiis"
  },
  new Albums {
    userId= 10,
    id= 92,
    title= "incidunt et et eligendi assumenda soluta quia recusandae"
  },
  new Albums {
    userId= 10,
    id= 93,
    title= "nisi qui dolores perspiciatis"
  },
  new Albums {
    userId= 10,
    id= 94,
    title= "quisquam a dolores et earum vitae"
  },
  new Albums {
    userId= 10,
    id= 95,
    title= "consectetur vel rerum qui aperiam modi eos aspernatur ipsa"
  },
  new Albums {
    userId= 10,
    id= 96,
    title= "unde et ut molestiae est molestias voluptatem sint"
  },
  new Albums {
    userId= 10,
    id= 97,
    title= "est quod aut"
  },
  new Albums {
    userId= 10,
    id= 98,
    title= "omnis quia possimus nesciunt deleniti assumenda sed autem"
  },
  new Albums {
    userId= 10,
    id= 99,
    title= "consectetur ut id impedit dolores sit ad ex aut"
  },
  new Albums {
    userId= 10,
    id= 100,
    title= "enim repellat iste"
  }




        };

        public IEnumerable<Albums> GetAllAlbums()
        {
            return album;
        }

        public IEnumerable<Albums> GetAlbum(int id)
        {         
            return album.Where(a => a.userId == id);
        }
    }
}
