using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoffeeApp2.Models;

namespace CoffeeApp2.ViewModels
{
    class NewsViewModel
    {
        public ObservableCollection<News> newsList { get; set; }

        public NewsViewModel()
        {
            newsList = new ObservableCollection<News>();

            newsList.Add(new News(
                "Is a coffee shortage inevitable as climate change gets worse?",
                "A cup of coffee to start the day is non-negotiable for millions of people around the world. We’ve been drinking it for hundreds of years, with the earliest references to our favourite pick-me-up dating back to the 15th century. \r\n Europeans are avid coffee enthusiasts.Some of the world’s most prolific coffee - drinking countries include Finland, Norway and Sweden, where they go through over 8 kg of the stuff, per person, every year.According to the International Coffee Organization globally this adds up to nine million tonnes being produced around the world every year. \r\n But what if one day soon our ability to grow this much - loved bean disappeared? \r\n A future without coffee is a reality we could all face as climate change threatens to permanently disrupt its complex supply chain. It is not so much the gradual rise of overall temperatures but incredible variation and wild weather swings that are putting production at risk. Existing coffee varieties struggle with extreme temperatures leading to low yields that could see farmers fail to keep up with the huge demand for the drink.",
                "A cup of coffee to start the day is non-negotiable for millions of people around the world...",
                "https://static.euronews.com/articles/stories/04/66/00/62/945x531_cmsv2_d06400cb-de60-5b05-81a8-fec1f182d6c4-4660062.jpg"
                ));
            newsList.Add(new News(
                "What is the best eco-friendly and reusable coffee cup on the market?",
                "Sustainability is the word on everyone's lips, however, we seem to forget about our environmental concerns as soon as we need our coffee fix. We plough through 2.5 billion of takeaway cups every year in the UK alone and less than 1% of those are recycled. \r\n Consumer behaviour must change and using reusable over recyclable cups seems to be the best way to tackle this issue.To make the transition easier, we have selected the best eco-friendly and reusable coffee cups on the market. \r\n It started over ten years ago in a Melbourne café with a simple idea: keep it and use it again. Coffee shop owners Jamie and Abigail Forsyth concerns were growing as they were witnessing the volume of disposable cups being consumed. \r\n In 2007, following unsuccessful trials of existing reusable cups, they decided to create their own: the KeepCup.Made of glass, it is designed by baristas for baristas and allows people to enjoy better and waste - free coffee on the go. “In 2009 we created the solution to a problem,” say the founders. “In 2019 we are leading the charge to ensure the world no longer needs, wants or uses disposable coffee cups.”",
                "Sustainability is the word on everyone's lips, however, we seem to forget about our environmental...",
                "https://static.euronews.com/articles/stories/03/77/07/86/945x531_cmsv2_79ae4e33-ed11-5090-ae7e-68d8f5f602dc-3770786.jpg"
                ));
            newsList.Add(new News(
                "Starbucks ventures into Italy, opening Europe's biggest cafe",
                "Starbucks, the world's biggest coffee chain, realised its chairman's dream on Friday after it opened an upmarket roastery and cafe in Milan, but the test will be to convince coffee-obsessed Italians to pay more for their daily espresso. \r\n The store will be the Seattle-based giant's first foray into the Italian market, the world's fourth-largest consumer of coffee, and comes 35 years after chairman emeritus Howard Schultz visited the country and was inspired to set up his own cafe chain. \r\n The venue features a green industrial-scale roaster, marble counters, brass engravings - and a price that could make many Italians reluctant to make it their regular cafe. \r\n At 1.80 euros for a simple espresso, Starbucks will charge nearly double what Italians pay at their local bars. 'The price reflects the premium experience we will offer customers, ' Starbucks Global President of Retail, John Culver, said.",
                "Starbucks, the world's biggest coffee chain, realised its chairman's dream on Friday after it...",
                "https://static.euronews.com/articles/stories/03/12/89/54/945x531_cmsv2_70552e9c-9175-534e-9374-3b775a30b586-3128954.jpg"
                ));
            newsList.Add(new News(
                "Meet the queen of the coffee capital of South Korea",
                "On South Korea’s eastern coast of one of the Winter Olympics sites of Gangneung sits a street of about 30 coffee shops overlooking the scenic Anmok Beach that are prepared to host foreign athletes, tourists, visitors and coffee aficionados. \r\n Among the café owners is Choi Geum Jeong. She opened the first modern-day coffee shop along this strip in 2001 and helped shape the area to what has now become known as 'Gangneung Coffee Street.' \r\n 'Gangneung is the coffee capital of Korea' said her worker Carol Song inside 'Coffee Cupper' near Anmok Beach. \r\n In the lightly dimmed room of baristas and specialty coffee brands stands Choi. She’s making a freshly prepared Ethiopian cup of coffee called Chelba in the back of the counter. It’s raspberry-flavored with a floral aroma that has a warm, sweet taste that’s comforting for one of the coldest winters to hit the country.",
                "On South Korea’s eastern coast of one of the Winter Olympics sites of Gangneung sits a street...",
                "https://static.euronews.com/articles/stories/03/08/07/40/773x435_story-f86b0260-a5a8-50a8-82fc-8440049adecf_616255.jpg"
                ));
            newsList.Add(new News(
                "Japan gets first robotised coffee house",
                "Japan's first Robot-Café opened its doors to media on Tuesday, (January 30), with a robot replacing the barista to serve coffee to patrons. Customers at 'Henn - na Café' meaning 'Strange Café' in Japanese, have to scan a QR code printed on a ticket bought from a vending machine in order to get a 320 yen ($3) coffee. \r\n The robot barista, called 'Sawyer', is able to serve a maximum of five cups of coffee at one go. One cup takes about four minutes to make. \r\n A cafe typically employs about four to five people to operate machines and serve coffee. Here, they are replaced by Sawyer and the automated coffee machine, which the general manager says will help keep the price of a cup of coffee low. \r\n The robot café follows a trend to solve labour shortages in rapidly ageing Japanese society, which raises questions about the future of human labour. \r\n This technological development is not new in Tokyo -- travel agency H.I.S. opened its third 'Henn-na hotel' in downtown Tokyo on Thursday (January 25) where robots help check guests in and clean the lobby instead of human staff, after the two other hotels in Tokyo and Nagasaki, southern Japan, became famous tourist attractions.",
                "Japan's first Robot-Café opened its doors to media on Tuesday, (January 30), with a robot...",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTs_G2rCZvMf70qZbU02JO1xUvO_FRfBDH1OQ&usqp=CAU"
                ));
        }
    }
}
