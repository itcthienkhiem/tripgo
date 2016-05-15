using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using Neo4j.Driver.V1;
//using Neo4jClient.Transactions;

namespace Tripgo.Models.DataContext
{
    public class DataContextImp:Model
    {
        public int insert()
        {
            throw new NotImplementedException();
        }

        public int update()
        {
            throw new NotImplementedException();
        }

        public int delete()
        {
            throw new NotImplementedException();
        }


        public object select()
        {
           using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "neo4j")))
           using (var trans1 = new TransactionScope(System.Transactions.TransactionScopeOption.RequiresNew, TimeSpan.FromDays(1)))
           
           using (var session = driver.Session())
           {

               session.Run("CREATE (a:Person {name:'Arthur', title:'King'})");

               var result = session.Run("MATCH (a:Person) WHERE a.name = 'Arthur' RETURN a.name AS name, a.title AS title");



               foreach (var record in result)
               {

                   //   Output.WriteLine($"{record["title"].As<string>()} {record["name"].As<string>()}");

               }

           }
           return null;
        }
    }
}