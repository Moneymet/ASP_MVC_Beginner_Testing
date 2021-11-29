using Xunit;

namespace asp_mvc_beginner_testing{
    public class testclass{
        [Fact]
        public void test(){
            Assert.True(true);
        }
        [Fact]
        public void test2(){
            Assert.True(false);
        }
    }

    
}