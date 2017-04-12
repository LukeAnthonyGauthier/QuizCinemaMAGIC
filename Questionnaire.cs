using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPresentationOral
{
    public class Questionnaire
    {
        public Question[] tableauQuestion = new Question[50];

        public Questionnaire()
        {

            tableauQuestion[0] = new Question("Qui a réalisé le film Un nouvel espoir (A New Hope), l'épisode IV de la série Star Wars?", "George Lucas", 1);
            tableauQuestion[1] = new Question("À quel grand chanteur Forrest Gump apprend-il à danser dans le long métrage du même nom? ", "Elvis Presley", 1);
            tableauQuestion[2] = new Question("Quel acteur assure le rôle du parrain de la mafia dans le film Le parrain (The Godfather)?", "Marlon Brando", 1);
            tableauQuestion[3] = new Question("De quel long métrage est tirée cette image? ", "E.T. ", 3);
            tableauQuestion[4] = new Question("Quel est le modèle de la voiture utilisée par Marty McFly pour voyager dans le temps dans Retour vers le futur(Back to the Future) ?", "DeLorean", 1);
            tableauQuestion[5] = new Question("Lequel des cinq films suivants n'a pas été réalisé par Robert Zemeckis? ", "Le diable s'habille en Prada (Devil Wears Prada)", 2);
            tableauQuestion[6] = new Question("Quel est le MacGuffin dans Fiction pulpeuse (Pulp Fiction)?", "La valise / mallette", 1);
            tableauQuestion[7] = new Question("Quel nom Alex DeLarge, le protagoniste du film Orange mécanique (A Clockwork Orange), donne-t-il à ses amis dans le long métrage?", "Droogs", 2);
            tableauQuestion[8] = new Question("Quel est le sujet de la dissertation demandée aux cinq jeunes en retenue dans The Breakfast Club?", "Qui pensez-vous être?", 2);
            tableauQuestion[9] = new Question("Quel est le nom de l'unique ami de Chuck Noland, le protagoniste de Seul au monde (Cast Away), lorsqu'il est sur l'île déserte?", "Wilson", 1);
            tableauQuestion[10] = new Question("Dans quel film retrouvons-nous originellement le personnage d'Hannibal Lecter?", "Le silence des agneaux (Silence of the Lambs)", 1);
            tableauQuestion[11] = new Question("En quelle année Fight club est-il sorti?", "1999", 1);
            tableauQuestion[12] = new Question("Parmi ces cinq longs métrages, lequel n'a pas été réalisé par Stanley Kubrick?", "Caligula", 2);
            tableauQuestion[13] = new Question("Qui est le réalisateur du Parc jurassique (Jurassic Park)? ", "Steven Spielberg", 1);
            tableauQuestion[14] = new Question("Quel est le titre de ce film? ", "Les dents de la mer (Jaws) ", 3);
            tableauQuestion[15] = new Question("Quel est le genre du long métrage Le bon, la brute et le truand (Il buono, il brutto, il cattivo)? ", "Western spaghetti", 2);
            tableauQuestion[16] = new Question("Quel est le nom du chien de Doc Emmett Brown dans Retour vers le futur (Back to the Future)?", "Einstein", 1);
            tableauQuestion[17] = new Question("De quelle organisation James Bond est-il membre dans la série de films du même nom? ", "MI6", 2);
            tableauQuestion[18] = new Question("De quel film est tiré ce décor? ", "Star Wars", 3);
            tableauQuestion[19] = new Question("De quel film provient la citation « On n'est jamais aussi bien que chez soi. » («There's no place like home. »)?", "Le magicien d'Oz (The Wizard of Oz)", 1);
            tableauQuestion[20] = new Question("Selon l'American Film Institute, à quelle position se retrouve L'exorciste (The Exorcist) de 1973 dans le palmarès des meilleurs thrillers?", "3e", 2);
            tableauQuestion[21] = new Question("Pendant quelle période historique se déroule La liste de Schindler (Schindler's List)?", "La Seconde Guerre mondiale", 1);
            tableauQuestion[22] = new Question("Qui est le réalisateur de Psychose (Psycho)?", "Alfred Hitchcock", 1);
            tableauQuestion[23] = new Question("Dans quel film québécois retrouve-t-on le personnage de Daniel Blanchette de Victoriaville?", "La guerre des tuques", 1);
            tableauQuestion[24] = new Question("Terminez la citation suivante, tirée des jumeaux Leroux dans La guerre des tuques : « La guerre, la guerre, (...) ».", "...c'est pas une raison pour se faire mal!", 1);
            tableauQuestion[25] = new Question("Qui a réalisé le long métrage Le déclin de l'empire américain?", "Denys Arcand", 1);
            tableauQuestion[26] = new Question("De quelle maladie décède la mère d'Aurore Gagnon dans le film qui porte son prénom?", "Tuberculose", 2);
            tableauQuestion[27] = new Question("Qui assure le rôle de Jean-Jacques, Gérard, Patrice et Serge dans le long métrage québécois Cruising Bar?", "Michel Côté", 1);
            tableauQuestion[28] = new Question("Lequel de ces acteurs n’apparaît pas dans Titanic? ", "Mattew McConaughey", 2);
            tableauQuestion[29] = new Question("Quel est le titre de ce film?", "La Matrice (Matrix)", 3);
            tableauQuestion[30] = new Question("De quelle bande fait partie Sandy Olsson dans Grease?", "Pink Ladies", 1);
            tableauQuestion[31] = new Question("Qui assure le rôle de Beetlejuice dans le film du même nom?", "Michael Keaton", 2);
            tableauQuestion[32] = new Question("Quel est le nom du lieutenant, puis matelot de Forrest Gump, joué par Cary Sinise dans le film du même nom?", "Dan Taylor", 1);
            tableauQuestion[33] = new Question("Nommez ces personnages de la série Star Wars. ", "R2-D2 et C-3PO ", 3);
            tableauQuestion[34] = new Question("De quel film est tiré cet extrait sonore?", "Tuer Bill (Kill Bill)", 1);
            tableauQuestion[35] = new Question("Quel est le nom du motel où l'histoire de Psychose (Psycho) se déroule?", "Adam's Motel", 2);
            tableauQuestion[36] = new Question("Quel est le nom du jeune ami d'E.T. dans le long métrage du même nom?", "Elliott", 2);
            tableauQuestion[37] = new Question("À quel moment se déroule le Titanic?", "Avril 1912", 2);
            tableauQuestion[38] = new Question("De quel film provient cette chanson?", "Grease", 1);
            tableauQuestion[39] = new Question("Quelle actrice incarne la princesse Leia dans la trilogie originale de Star Wars?", "Carrie Fisher", 1);
            tableauQuestion[40] = new Question("Quel nom porte le collier de Rose dans Titanic? ", "Le cœur de l'océan", 1);
            tableauQuestion[41] = new Question("De quel film est tirée cette image? ", "Forrest Gump", 3);
            tableauQuestion[42] = new Question("Quelles sont les trois règles qui s’appliquent lors que l’on prend soin de l’un des Mogwaï du long métrage Les gremlins (Gremlins)?", "Ne pas l’exposer à la lumière, ne pas le mouiller et ne jamais lui donner à manger après minuit.", 2);
            tableauQuestion[43] = new Question("Quel est le nom du meurtrier dans la série de films Halloween?", "Michael Myers", 2);
            tableauQuestion[44] = new Question("Quel acteur assure le rôle du docteur Malcom Crowe dans Sixième Sens (The Sixth Sense)?", "Bruce Willis", 1);
            tableauQuestion[45] = new Question("Terminez le titre suivant : Vol au-dessus d’un (…) (One Flew Over the (…)).", "…nid de coucou (…Cuckoo’s Nest)", 1);
            tableauQuestion[46] = new Question("De quel film vient cette citation : « La vie passe très vite. Si vous ne vous arrêtez pas parfois pour l’observer, vous pourriez la rater .» (« Life moves pretty fast. If you don’t stop and look around once in a while, you could miss it. »)?", "La folle journée de Ferris Buller (Ferris Buller’s Day Off)", 2);
            tableauQuestion[47] = new Question("Quel est le titre de ce film?", "King Kong", 3);
            tableauQuestion[48] = new Question("Lequel de ces cinq films n’a pas été réalisé par Martin Scorsese?", "Gatsby le magnifique (The Great Gatsby)", 2);
            









        }
    }
}
