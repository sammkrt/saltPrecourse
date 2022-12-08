namespace TrainingGround.Tests
{
    public class LoopTest
    {
        [Fact]
        public void while_loop()
        {
            // arrange
            var ints = new int[] { 1, 2, 3, 4, 5 };

            // act
            var i = 0;
            while (i < ints.Length)
            {
                var currentValueInTheLoop = ints[i];
                Console.WriteLine($"i is now '{i}'");
                Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

                // assert
                Assert.Equal(i + 1, currentValueInTheLoop);
    
                i++;
            }
        }

        [Fact]
        public void for_loop()
        {
            // arrange
            var ints = new int[] { 1, 2, 3, 4, 5};

            // act
            for (var i =0; i < ints.Length; i++)
            {
                var currentValueInTheLoop = ints[i];
                
                Console.WriteLine($"i is now '{i}'");
                Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");
            
                // Assert
                Assert.Equal(i + 1, currentValueInTheLoop);
            }
        }    
        
        [Fact]
        public void for_each_loop()
        {
            // arrange
            var ints = new int[] { 1, 2, 3, 4, 5};
            var i = 0;
            // act 
            foreach (var currentValueInTheLoop in ints)
            {
                Console.WriteLine($"i is now '{i}'");
                Console.WriteLine($"currentvalueInTheLoop is now'{currentValueInTheLoop}'");
                i++;
                // assert
                Assert.IsType<int>(currentValueInTheLoop);
            }
        }    
    
        [Fact]
        public void for_each_loop_over_addresses()
        {
            // arrange
            var addressList = new List<Address>();
            addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 3 });
            var n = 1;

            // act
            foreach (var currentValueInTheLoop in addressList)
            {
                Console.WriteLine($"{n}. Street no of Adress is {currentValueInTheLoop.StreetNo}");
                n++;
            
            // assert
                Assert.IsType<Address>(currentValueInTheLoop);
            }
        }
    
        [Fact]
        public void break_stops_loops()
        {
            // arrange
            var addressList = new List<Address>();
            addressList.Add(new Address() { Street = "Street" , StreetNo = 1 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

            //act
            var foundIt = false;
            foreach (var currentValueInTheLoop in addressList)
            {
                if (currentValueInTheLoop.StreetNo == 2)
                {
                    foundIt = true;
                    break;
                }
            }
            
            // assert
            Assert.True(foundIt);
        }
    }
}