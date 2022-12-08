namespace TrainingGround.Tests
{
    public class CollectionTests
    {
        
        [Fact]
        public void an_array_has_a_length()
        { 
            
            // act
            var arrayOfIntegers = new int[5];
            var arrayofIntegersWithValues = new int[] { 1, 2, 3};
            var arrayOfStrings = new string[] { "Name 1", "Name 2" };

            // assert
            Assert.Equal(5, arrayOfIntegers.Length);
            Assert.Equal(3, arrayofIntegersWithValues.Length);
            Assert.Equal(2, arrayOfStrings.Length);

        }

        [Fact]
        public void getting_items_out()
        {
            // act
            var arrString = new string[] { "Name 1", "Name 2"};

            // assert
            Assert.Equal("Name 1", arrString[0]);
            Assert.Equal("Name 2" , arrString[1]);
        }
    
        [Fact]
        public void a_list_of_integers_is_very_flexible()
        {
            // arrange
            var integerList = new List<int>();

            // act
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);
            integerList.RemoveAt(0);

            // assert
            Assert.Equal(2, integerList.Count);
            Assert.Equal(2, integerList[0]);
            Assert.Equal(3, integerList[1]);

        }
    
        [Fact]
        public void lists_can_hold_anything()
        {
            // arrange 
            var intList = new List<int>();
            var stringList = new List<string>();
            var addressList = new List<Address>();

            // act
            intList.Add(1); intList.Add(2); intList.Add(3);
            stringList.Add("1"); stringList.Add("2"); stringList.Add("3");
            addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
            addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

            // assert
            Assert.IsType<int>(intList[0]);
            Assert.IsType<string>(stringList[0]);
            Assert.IsType<Address>(addressList[0]);
            Assert.IsNotType<int>(addressList[0]);
        }
    
    
    }
}