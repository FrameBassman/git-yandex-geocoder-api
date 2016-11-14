namespace Yandex.Api.Entities
{
    using System.Globalization;

    using RestSharp.Deserializers;

    public class Point
    {
        [DeserializeAs(Name = "pos")]
        public Pos Pos { get; set; }

        public double Latitude => double.Parse(this.Pos.Value.Split(' ')[0], CultureInfo.InvariantCulture);

        public double Longitude => double.Parse(this.Pos.Value.Split(' ')[1], CultureInfo.InvariantCulture);
    }
}
