namespace TPOAS_1.Tests
{
    public class TPOAS_1_Tests
    {

        [Fact]
        public void Otrezok_Len_zero()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double expected = 0;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_int_pos()
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 3;
            double y2 = 4;
            double expected = 2.83;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_double_pos()
        {
            double x1 = 1.1;
            double y1 = 2.2;
            double x2 = 3.3;
            double y2 = 4.4;
            double expected = 3.11;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_int_neg()
        {
            double x1 = -1;
            double y1 = -2;
            double x2 = -3;
            double y2 = -4;
            double expected = 2.83;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_double_neg()
        {
            double x1 = -1.1;
            double y1 = -2.2;
            double x2 = -3.3;
            double y2 = -4.4;
            double expected = 3.11;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_int_pos_plus_int_neg()
        {
            double x1 = 1;
            double y1 = -2;
            double x2 = 3;
            double y2 = -4;
            double expected = 2.83;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_double_pos_plus_double_neg()
        {
            double x1 = 1.1;
            double y1 = -2.2;
            double x2 = 3.3;
            double y2 = -4.4;
            double expected = 3.11;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_int_pos_plus_double_neg()
        {
            double x1 = 1;
            double y1 = -2.2;
            double x2 = 3;
            double y2 = -4.4;
            double expected = 2.97;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_double_pos_plus_int_neg()
        {
            double x1 = 1.1;
            double y1 = -2;
            double x2 = 3.3;
            double y2 = -4;
            double expected = 2.97;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Otrezok_Len_zero_plus_int_pos()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 3;
            double y2 = 4;
            double expected = 5;
            Otrezok c = new Otrezok();

            double actual = c.Len(x1, y1, x2, y2);

            Assert.Equal(expected, actual);
        }
    }
}
