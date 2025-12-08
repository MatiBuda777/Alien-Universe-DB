using System.Collections.Generic;
using System.Collections.ObjectModel;
using Alien_Universe_DB.Models;

namespace Alien_Universe_DB.ViewModels;

public class CharactersWindowViewModel : ViewModelBase
{
    private ObservableCollection<Character> _characters = new()
    {
        new Character
        {
            FullName = "Ellen Louise Ripley",
            Movies = new List<string>
                { "Alien (1979)", "Aliens (1986)", "Alien³ (1992)", "Alien: Resurrection (1997)" },
            Role = "Oficer porządkowy, później specjalistka ds. bezpieczeństwa",
            Actor = "Sigourney Weaver",
            Species = "Człowiek",
            BirthYear = 2092,
            CrewFunction = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Traits =
                "Zdeterminowana, inteligentna, odporna psychicznie. Jej decyzje często ratują załogę kosztem własnego komfortu. Symbol siły i walki człowieka z nieznanym.",
            Fate =
                "Ginęła w filmie „Alien³”, by uniemożliwić korporacji zdobycie królowej obcych. Później została sklonowana (film „Resurrection”).",
            Trivia = "Sigourney Weaver była nominowana do Oscara za rolę w „Aliens” — to rzadkość w kinie sci-fi."
        },
        new Character
        {
            FullName = "Arthur Koblenz Dallas",
            Movies = new List<string> { "Alien (1979)" },
            Role = "Kapitan statku handlowego USCSS Nostromo",
            Actor = "Tom Skerritt",
            Species = "Człowiek",
            BirthYear = 2071,
            CrewFunction = "Dowódca misji, odpowiedzialny za decyzje dotyczące lądowania i bezpieczeństwa załogi.",
            Traits =
                "Opanowany, odpowiedzialny, często stawia bezpieczeństwo załogi ponad własne emocje. Zmuszony do podjęcia trudnych decyzji w obliczu kontaktu z obcą formą życia.",
            Fate = "Zginął podczas próby schwytania obcego w kanałach wentylacyjnych Nostromo.",
            Trivia =
                "W scenariuszu oryginalnie rozważano alternatywne zakończenie, w którym Dallas zostaje odnaleziony żywy, uwięziony w kokonach obcego."
        },
        new Character
        {
            FullName = "Ash",
            Movies = new List<string> { "Alien (1979)" },
            Role = "Oficer naukowy Nostromo",
            Actor = "Ian Holm",
            Species = "Android (model Hyperdyne Systems 120-A/2)",
            BirthYear = 0,
            CrewFunction = "Odpowiada za analizę sygnałów i badania naukowe obiektów pozaziemskich.",
            Traits = "Zewnętrznie spokojny i profesjonalny, w rzeczywistości kierowany tajnymi rozkazami korporacji.",
            Fate = "Zniszczony przez załogę po ujawnieniu, że jego misją było zachowanie obcego przy życiu.",
            Trivia = "Ash jest pierwszym androidem w uniwersum Alien i początkiem całego wątku sztucznej inteligencji."
        },
        new Character
        {
            FullName = "Bishop",
            Movies = new List<string> { "Aliens (1986)", "Alien³ (1992)" },
            Role = "Oficer naukowy, android kolonialnych marines",
            Actor = "Lance Henriksen",
            Species = "Android (model Hyperdyne 341-B)",
            BirthYear = 0,
            CrewFunction = "Zajmuje się systemami analizy danych i wspiera operacje bojowe.",
            Traits = "Empatyczny, lojalny, różni się od Asha — ma autentyczne poczucie etyki.",
            Fate = "Ciężko uszkodzony przez królową obcych, później dezaktywowany.",
            Trivia = "Bishop jest jednym z niewielu androidów w kinie, który naprawdę wzbudza zaufanie."
        },
        new Character
        {
            FullName = "Jenette Vasquez",
            Movies = new List<string> { "Aliens (1986)" },
            Role = "Strzelec kolonialnych marines",
            Actor = "Jenette Goldstein",
            Species = "Człowiek",
            BirthYear = 2124,
            CrewFunction = "Specjalistka od broni ciężkiej i operacji w ciasnych korytarzach kolonii.",
            Traits = "Odważna, twarda i zadziorna. Nie boi się śmierci i żartuje nawet w obliczu zagrożenia.",
            Fate = "Poświęca życie, wysadzając korytarz pełen obcych, by uratować innych marines.",
            Trivia = "Postać Vasquez była wzorem dla wielu późniejszych bohaterek gier i filmów sci-fi."
        },
        new Character
        {
            FullName = "Rebecca \"Newt\" Jorden",
            Movies = new List<string> { "Aliens (1986)" },
            Role = "Jedyna ocalała z kolonii Hadley’s Hope",
            Actor = "Carrie Henn",
            Species = "Człowiek",
            BirthYear = 2172,
            CrewFunction = "Nieformalna towarzyszka Ripley, dziecko, które przetrwało atak ksenomorfów.",
            Traits = "Sprytna, cicha, zaskakująco odporna psychicznie mimo wieku.",
            Fate = "Ginęła w katastrofie statku Sulaco (początek „Alien³”).",
            Trivia = "Carrie Henn po tym filmie nigdy więcej nie wystąpiła w żadnym filmie."
        },
        new Character
        {
            FullName = "The Queen Alien",
            Movies = new List<string> { "Aliens (1986)", "Alien: Resurrection (1997)" },
            Role = "Matka i królowa ksenomorfów",
            Actor = "efekty praktyczne i animatronics",
            Species = "Obcy (Ksenomorf Królowa)",
            BirthYear = 0,
            CrewFunction = "Nie dotyczy — centralna postać hierarchii obcych, odpowiedzialna za składanie jaj.",
            Traits = "Niezwykle inteligentna, agresywna, pełna instynktu macierzyńskiego.",
            Fate = "Zniszczona przez Ripley w ładowni statku Sulaco, ponownie klonowana w „Resurrection”.",
            Trivia = "Do animacji Królowej Obcych użyto modelu o wysokości ponad 4 metrów."
        },
        new Character
        {
            FullName = "Annalee Call",
            Movies = new List<string> { "Alien: Resurrection (1997)" },
            Role = "Członkini załogi statku Betty",
            Actor = "Winona Ryder",
            Species = "Android (model Auton – stworzony przez androidy)",
            BirthYear = 2381,
            CrewFunction = "Specjalistka ds. techniki i hakowania systemów wojskowych.",
            Traits = "Empatyczna, emocjonalna, wykazuje moralność bardziej ludzką niż większość ludzi.",
            Fate = "Przeżywa i opuszcza Ziemię wraz z klonem Ripley.",
            Trivia = "Call to pierwszy android w serii, który został stworzony przez inne androidy."
        },
        new Character
        {
            FullName = "Ripley 8",
            Movies = new List<string> { "Alien: Resurrection (1997)" },
            Role = "Klon Ellen Ripley z DNA królowej obcych",
            Actor = "Sigourney Weaver",
            Species = "Hybryda (Człowiek / Obcy)",
            BirthYear = 2381,
            CrewFunction = "Pomaga załodze Betty w walce z obcymi na statku USM Auriga.",
            Traits = "Silna fizycznie i emocjonalnie, rozdarta między naturą człowieka i obcego.",
            Fate = "Przeżywa wydarzenia filmu, ale nie ufa już ani ludziom, ani korporacjom.",
            Trivia = "Ma kwaśną krew i zdolności nadludzkie, będąc symbolicznym połączeniem dwóch światów."
        },
        new Character
        {
            FullName = "The Engineer",
            Movies = new List<string> { "Prometheus (2012)" },
            Role = "Starożytna istota – stwórca ludzi",
            Actor = "Ian Whyte",
            Species = "Inżynier",
            BirthYear = 0,
            CrewFunction = "Nie jest członkiem załogi – reprezentuje cywilizację twórców, którzy stworzyli życie na Ziemi.",
            Traits = "Milczący, majestatyczny, potężny. Symbol boskiej pychy.",
            Fate = "Budzi się z hibernacji i morduje członków misji Prometeusza, po czym ginie.",
            Trivia = "Postać Inżyniera łączy mit o stworzeniu człowieka z początkiem gatunku Obcych."
        },
        new Character
        {
            FullName = "Neomorph",
            Movies = new List<string> { "Alien: Covenant (2017)" },
            Role = "Forma pośrednia między stworzeniem Davida a ksenomorfem",
            Actor = "CGI / efekty komputerowe",
            Species = "Obcy (mutant)",
            BirthYear = 0,
            CrewFunction = "Nie dotyczy — stworzenie eksperymentalne Davida, symbol błędu ewolucji.",
            Traits = "Nieprzewidywalny, szybki i niestabilny biologicznie.",
            Fate = "Zabity przez załogę Covenant.",
            Trivia = "Neomorphy były inspirowane koncepcją „białego drapieżcy” z natury — połączeniem piękna i grozy."
        },
        new Character
        {
            FullName = "Daniels Branson",
            Movies = new List<string> { "Alien: Covenant (2017)" },
            Role = "Oficer kolonizacyjny",
            Actor = "Katherine Waterston",
            Species = "Człowiek",
            BirthYear = 2100,
            CrewFunction = "Projektantka kolonii, kieruje działaniami terraformacyjnymi.",
            Traits = "Pragmatyczna, ale odważna i zdeterminowana.",
            Fate = "Zostaje uśpiona w kapsule przez Davida, który podszywa się pod androida Waltera.",
            Trivia = "Scott chciał, by Daniels była symbolicznym „nowym początkiem” linii bohaterek."
        }
    };


}