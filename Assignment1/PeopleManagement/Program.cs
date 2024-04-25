CsvParser parser = new ();
List<Person> people = parser.Parse();

PeopleReport report = new ();
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveMales(people.ToArray(), "males.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");
