using System.Collections.Generic;
using System.Linq;
using movieappnew.Models;

namespace movieappnew.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies =null;

        static MovieRepository() {

            _movies= new List<Movie> ()
            {
                new Movie() { 
                    Id=1,
                    Name="Shang-Chi ve On Halka Efsanesi", 
                    Description ="<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ducimus sapiente ut, tempora maiores inventore eligendi non odit quos magnam quisquam quidem ad explicabo assumenda facere consequatur sed quas autem magni dolor hic fugiat dolorem. Tempore eos cum maxime doloribus incidunt hic aspernatur aliquam nihil minus, dolores officiis distinctio vitae sed blanditiis tempora voluptas! Optio hic ipsam dolore molestiae perferendis soluta aspernatur quisquam impedit magnam sint illo ducimus, incidunt maxime aut voluptas recusandae vel quasi mollitia fugiat libero? Accusamus possimus at officia enim. Reprehenderit dolore voluptate, reiciendis eaque voluptatum accusamus, sit quas at mollitia perferendis blanditiis. Itaque dolorem laboriosam maiores culpa.</p>",           
                    SortDescription="Shang-Chi ve On Halka Efsanesi",
                    ImageUrl="1.jpg",
                    CategoryId=1                   
                    },
                new Movie() { 
                    Id=2,
                    Name="Örümcek-Adam Eve Dönüş Yok",
                    Description  ="<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ducimus sapiente ut, tempora maiores inventore eligendi non odit quos magnam quisquam quidem ad explicabo assumenda facere consequatur sed quas autem magni dolor hic fugiat dolorem. Tempore eos cum maxime doloribus incidunt hic aspernatur aliquam nihil minus, dolores officiis distinctio vitae sed blanditiis tempora voluptas! Optio hic ipsam dolore molestiae perferendis soluta aspernatur quisquam impedit magnam sint illo ducimus, incidunt maxime aut voluptas recusandae vel quasi mollitia fugiat libero? Accusamus possimus at officia enim. Reprehenderit dolore voluptate, reiciendis eaque voluptatum accusamus, sit quas at mollitia perferendis blanditiis. Itaque dolorem laboriosam maiores culpa.</p>", 
                    SortDescription="Örümcek-Adam Eve Dönüş Yok",
                    ImageUrl="2.jpg",
                    CategoryId=2
                    },
                new Movie() { 
                    Id=3,
                    Name="The Matrix Resurrections",
                    Description  ="<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ducimus sapiente ut, tempora maiores inventore eligendi non odit quos magnam quisquam quidem ad explicabo assumenda facere consequatur sed quas autem magni dolor hic fugiat dolorem. Tempore eos cum maxime doloribus incidunt hic aspernatur aliquam nihil minus, dolores officiis distinctio vitae sed blanditiis tempora voluptas! Optio hic ipsam dolore molestiae perferendis soluta aspernatur quisquam impedit magnam sint illo ducimus, incidunt maxime aut voluptas recusandae vel quasi mollitia fugiat libero? Accusamus possimus at officia enim. Reprehenderit dolore voluptate, reiciendis eaque voluptatum accusamus, sit quas at mollitia perferendis blanditiis. Itaque dolorem laboriosam maiores culpa.</p>", 
                    SortDescription="The Matrix Resurrections",
                    ImageUrl="3.jpg",
                    CategoryId=3
                    },
                new Movie() { 
                    Id=4,
                    Name="Dune:Çöl Gezegeni",
                    Description  ="<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ducimus sapiente ut, tempora maiores inventore eligendi non odit quos magnam quisquam quidem ad explicabo assumenda facere consequatur sed quas autem magni dolor hic fugiat dolorem. Tempore eos cum maxime doloribus incidunt hic aspernatur aliquam nihil minus, dolores officiis distinctio vitae sed blanditiis tempora voluptas! Optio hic ipsam dolore molestiae perferendis soluta aspernatur quisquam impedit magnam sint illo ducimus, incidunt maxime aut voluptas recusandae vel quasi mollitia fugiat libero? Accusamus possimus at officia enim. Reprehenderit dolore voluptate, reiciendis eaque voluptatum accusamus, sit quas at mollitia perferendis blanditiis. Itaque dolorem laboriosam maiores culpa.</p>", 
                    SortDescription="Dune:Çöl Gezegeni",
                    ImageUrl="4.jpg",
                    CategoryId=4
                    },
                new Movie() {
                     Id=5,
                     Name="Venom: Zehirli Öfke 2",
                     Description  ="<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ducimus sapiente ut, tempora maiores inventore eligendi non odit quos magnam quisquam quidem ad explicabo assumenda facere consequatur sed quas autem magni dolor hic fugiat dolorem. Tempore eos cum maxime doloribus incidunt hic aspernatur aliquam nihil minus, dolores officiis distinctio vitae sed blanditiis tempora voluptas! Optio hic ipsam dolore molestiae perferendis soluta aspernatur quisquam impedit magnam sint illo ducimus, incidunt maxime aut voluptas recusandae vel quasi mollitia fugiat libero? Accusamus possimus at officia enim. Reprehenderit dolore voluptate, reiciendis eaque voluptatum accusamus, sit quas at mollitia perferendis blanditiis. Itaque dolorem laboriosam maiores culpa.</p>", 
                     SortDescription="Venom: Zehirli Öfke 2",
                     ImageUrl="5.jpg",
                    CategoryId=5
                    }
               
            };

        }
       public static List<Movie> Movies
        {
           get
           {
               return _movies;
            }
        }

        public static void AddMovie(Movie entity)
       {
             _movies.Add(entity);
       }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}