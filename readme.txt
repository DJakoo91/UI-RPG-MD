UIRPG Dzintars Jakovelis EKA DIG_P2

= = = UI
Intuitīvs un saprotams interfeiss, kurā var redzēt visu info:

=== Player Info:
- Name                   parāda spēlētāja iestatīto nickname. (Tagad iestatīts mans - DJakoo);
- Health (kreisajā pusē) parāda spēlētāja atlikušās dzīvības;
- Shield                 parāda vai vairogs ir aktīvs (Pie šī parametra parādās ķeksītis);

=== Enemy Info:
- Enemy                  parāda ar kuru pretinieku tagad spēlētājs cīnās;
- Health (labajā pusē)   parāda cik dzīvības ir palikušas pretiniekam;

=== Pārējais UI:
- Round No               parāda cik gājienu ir noticis spēles laikā;
- UI poga Shield         ieslēdz vai izslēdz vairogu;
- UI poga Attack         pārslēdz spēli uz nākamo raundu;
- UI poga Change Weapon  pārslēdz spēli uz nākamo raundu;


= = = Vairogs
Vairogs samazina ienākošo damage spēlētājam uz 50%. (Spēlētāja health ir integers, taču kodā to noapaļoju (Mathf.RoundToInt)).
Savukārt, nesanāca sataisīt vairoga salūzšanas mehāniku. To var izmantot visu laiku bez ierobežojumiem.
Vairogu var ieslēgt un izslēgt ar UI pogu, kas ir apakšā, kreisajā pusē.
Ja vairogs bija ieslēgts pirms tam kā enemy uzbruka spēlētājam, tad to arī var redzēt Konsolē.

= = = Attack
Poga attack pieskaita 1 raundu skaitītājam, un tad tas izvadās uz UI.
Katrā raundā gan spēlētājs gan enemy viens otram uzbrūk kā arī visa informācija par cīņas gaitu izvadās Konsolē.

= = = Change Weapon
Uzspiežot šo UI pogu bija jāmainās spēlētāja uzbrukuma damage uz 2, kas ir diez gan maz un imitē dūru cīņu.
Character klasē esmu iesācis šo mehāniku, taču tā man neiznāca līdz galam, un tagad ir palicis tikai tās mehānikas pirmssākums,
kā arī Konsolē izvadās paziņojums ka spēlētājs ir nomainījis ieroci.

= = = Death Screen
Pats parastākais Game Over screen. Ekrāns aptumst, parādās teksts ar informāciju kas tikko notika, kā arī poga Restart,
kuru uzspiežot palaižas 0. scēna, kura arī ir tā, kurā notiek visa spēles darbība.