using System;
using System.Threading.Tasks;

namespace EasyRecipezy.Core.DummyData
{
    public static class DummyRecipes
    {
        public static async Task<string> GetDummyData()
        {
            string rawJson = "[" +
                "  {" +
                "\"ingredients\": \"Pasta nEggs nBlack Pepper\"," +
                "\"method\": \"1. Put the egg yolks into a bowl, grate in the Parmesan, season with pepper, then mix well with a fork and put to one side.nn2. Cut any hard skin off the pancetta and set aside, then chop the meat.nn3. Cook the spaghetti in a large pan of boiling salted water until al dente./4. Meanwhile, rub the pancetta skin, if you have any, all over the base of a medium frying pan, then place over a medium-high heat.nn5. Stir the pancetta for 4 minutes, or until it starts to crisp up.nn6. Reserve some of the cooking water, drain and add the spaghetti. Toss well over the heat so it really soaks up all the flavour, then remove the pan from the heat.nn7. Add a splash of the cooking water and toss well, season with pepper, then pour in the egg mixture – the pan will help to cook the egg gently, rather than scrambling it. Toss well, adding more cooking water until it’s lovely and glossy.nn8. Serve with a grating of Parmesan and an extra twist of pepper.\"," +
                "\"name\": \"Carbonara\"," +
                "\"duration\": \"20 min\"," +
                "\"difficulty\": \"easy\"," +
                "\"image\": \"https://null/" +
                "}, {" +
                "\"ingredients\": \"3 tbsp olive oil n1 onion n1 carrot n1 garlic cloves, crushed n500g pack beef n500g pack pork mince n200ml milk n2 x 400g cans chopped tomatoes n2 bay leaves n1 rosemary n500ml red wine n400g dried pasta sheets n50g parmesan, finely grated nnFor the white sauce (béchamel) nn1½ l milk n100g butter n100g plain flour ngood grating of nutmeg\"," +
                "\"method\": \"1. First infuse the milk to make the béchamel sauce. Put the milk, the butter and the flour, into a large saucepan and bring very gently just up to the boil. Turn off the heat and set aside for 1 hr to infuse. Gently bubble for a few mins until thickened. Season with salt, pepper and nutmeg. Keep it aside.nn2. For the meat sauce, put the oil, celery, onion, carrot and garlic, in another large saucepan. Gently cook together until the veg are soft but not coloured.nn3. Tip in all the mince, the milk and tomatoes. Using a wooden spoon, stir together and break up and mash the lumps of mince against the sides of the pan.nn4. When the mince is mostly broken down, stir in all the herbs and bring to a simmer. Cover and cook for 1 hr, stirring occasionally to stop the bottom catching. Uncover and gently simmer for another 30 mins-1 hr until the meat is tender and saucy. Taste and season.nn5. Heat oven to 180C/160C fan/gas 4. Spread a spoonful of the meat sauce over the base of a roughly 3.5 litre baking dish. Cover with a single layer of pasta sheets, snapping them to fit if needed, then top with a quarter of the béchamel. Spoon over a third of the meat sauce and scatter over a little Parmesan.nn6. Repeat the layers – pasta, béchamel, meat and Parmesan – two more times to use all the meat sauce. Add a final layer of pasta, the last of the béchamel and remaining Parmesan. Sit the dish on a baking tray to catch spills and bake for 1 hr until bubbling, browned and crisp on top.\"," +
                "\"name\": \"Lasagne\"," +
                "\"duration\": \"2 hours\"," +
                "\"difficulty\": \"hard\"," +
                "\"image\": \"https://null/" +
            "}, {" +
                "\"ingredients\": \"1 cloves of garlic n20g  bunch of fresh basil nolive oil n3 x 400 g good-quality tinned plum tomatoes\"," +
                "\"method\": \"1. Peel and finely slice the garlic. Pick the basil leaves and tear into pieces.nn2. Place a large non-stick frying pan on the heat and pour in 4 generous lugs of olive oil. Add the garlic, shake the pan around a bit and, once the garlic begins to colour lightly, add the basil and the tomatoes. Using the back of a wooden spoon, mush and squash the tomatoes as much as you can.nn3. Season the sauce with sea salt and freshly ground black pepper. As soon as it comes to the boil, remove the pan from the heat.nn4. Strain the sauce through a coarse sieve into a bowl, using your wooden spoon to push any larger bits of tomato through. Discard the basil and garlic that will be left in the sieve, but make sure you scrape any of the tomatoey goodness off the back of the sieve into the bowl.nn5. Pour the sauce back into the pan, bring to the boil, then turn the heat down and simmer for 5 minutes to concentrate the flavours. It will be ready when it’s the perfect consistency for spreading on your pizza.nn6. Store the sauce in a clean jar in the fridge – it’ll keep for a week or so.\"," +
                "\"name\": \"Tomato Sauce\"," +
                "\"duration\": \"20 mins\"," +
                "\"difficulty\": \"easy\"," +
                "\"image\": \"https://null/" +
                "}, {" +
                "\"ingredients\": \"500g pound lean ground beef n200g fresh bread crumbs n1 tablespoon dried parsley n1 tablespoon grated Parmesan cheese nblack pepper ngarlic n1egg, beaten\"," +
                "\"method\": \"1. In a large bowl, combine ground beef, bread crumbs, parsley, Parmesan, 1/4 teaspoon black pepper, garlic and beaten egg.nn2. Mix well and form into 12 balls. Store, covered, in refrigerator until needed.nn3. In a large saucepan over medium heat, saute onion and garlic in olive oil until onion is translucent. nn4. Stir in tomatoes, salt, sugar and bay leaf. Cover, reduce heat to low, and simmer 90 minutes. nn5. Stir in basil, 1/2 teaspoon pepper and meatballs and simmer 30 minutes more. Serve.\"," +
                "\"name\": \"Meatballs\"," +
                "\"duration\": \"2 hours\"," +
                "\"difficulty\": \"medium\"," +
                "\"image\": \"https://null/" +
                "}, {" +
                "\"ingredients\": \"1kg strong white bread flourn600ml of watern20g fine sea saltn7 g sachets of dried yeastn1 tablespoon caster sugarn60g olive oiln1 clove of garlicn1 bunch of fresh basilnolive oiln1 x 400 g tin of quality plum tomatoesn200 g mozzarella cheese\"," +
                "\"method\": \"1. For the dough, pile the flours and the sea salt onto a large bowl and mix well.nn2. Mix the yeast, sugar and the warm water together and leave for a few minutes, then pour into the flour.nn3. Using a fork and a circular movement start mixing the ingredients. Continue to mix, bringing in all the flour – when the dough comes together and becomes too hard to mix with your fork, flour your hands and begin to pat it into a ball.nn4. Knead the dough by rolling it backwards and forwards, using your hands to stretch, pull and push the dough. Keep kneading for 10 minutes, or until you have a smooth, springy, soft dough.nn5. Cover the dough with clingfilm and leave in a warm place to to prove for 2 hours, or until doubled in size.nn6. For the sauce, peel and finely slice the garlic, then pick the basil leaves and finely chop the stalks.nn7. Heat 1 tablespoon of oil in a pan on a medium-low heat, add the garlic and basil stalks, then cook gently for a couple of minutes, or until the garlic is lightly golden, then add most of the basil leaves, the tomatoes, and a pinch of salt and pepper.nn8. Leave the sauce to tick away for around 20 minutes, or until smooth, breaking up the tomatoes up with a wooden spoon. When the time’s up, taste, and season to perfection.nn9. divide the dough into 6 equal balls.nn10. Dust a clean surface and the dough with a little flour and roll it out into a rough circle, about ½cm thick.nn11. Tear off an appropriately sized piece of tin foil, rub it with olive oil, dust well with flour or semolina and place the pizza base on top. Continue doing the same with the remaining dough, dust with a little flour so you can pile them up. Cover with clingfilm and place in the fridge.nn12. When you're ready to cook them, preheat the oven to 250°C/500°F/gas 9.nn13. At this stage you can apply your topping: spread the tomato sauce over the base, spreading it out to the edges. Tear over the mozzarella and scatter with the remaining basil leaves. Drizzle with a tiny bit of olive oil and add a pinch of salt and pepper.nn14. Cook for 7 to 10 minutes, until the pizzas are golden and crispy.\"," +
                "\"name\": \"Pizza Margherita\"," +
                "\"duration\": \"3 hours\"," +
                "\"difficulty\": \"hard\"," +
                "\"image\": \"https://null/" +
                "}," +
                "{" +
                "\"ingredients\": \"2 potatoes n2cups flours n1egg\"," +
                "\"method\": \"1. Bring a large pot of salted water to a boil. Peel potatoes and add to pot. Cook until tender but still firm, about 15 minutes. Drain, cool and mash with a fork or potato masher.nn2. Combine 1 cup mashed potato, flour and egg in a large bowl. Knead until dough forms a ball. Shape small portions of the dough into long snakes. On a floured surface, cut snakes into half inch pieces.nn3. Bring a large pot of lightly salted water to a boil. Drop in gnocchi and cook for 3 to 5 minutes or until gnocchi have risen to the top, drain and serve.\"," +
                "\"name\": \"Gnocchi\"," +
                "\"duration\": \"1 hours\"," +
                "\"difficulty\": \"medium\"," +
                "\"image\": \"https://null/" +
            "  }," +
                "  {" +
                "  \"ingredients\": \"50g of small basil n1/2 cup of extra virgin olive oil n70 g of Parmigiano Reggiano or Grana Padano /n30 g of Pecorino cheese /n2 peeled garlic cloves /n15 g of pine nuts /n4/5 grains of coarse salt\"," +
                "  \"method\": \"1. Prepare basil leaves washing them with cold water. /n2. Place them in a large bowl with plenty of ice for 3-4 minutes. /n3. When all it’s ready, place basil leaves (without the ice) into the blender with garlic, pine nuts and grated Parmigiano.\"," +
                "  \"name\": \"Pesto\"," +
                "  \"duration\": \"15 mins\"," +
                "  \"difficulty\": \"easy\"," +
                "  \"image\": \"https://null/" +
                "  }," +
                "  {" +
                "    \"ingredients\": \"300g of flour n3 eggs\"," +
                "    \"method\": \"1. Heap the flour, and make a well in it. Break the eggs into the well. Beat eggs with a fork. Stir into the flour from the bottom of the well with the fork until the dough in the center is smooth or shiny. nn2. With your hands, gradually incorporate the flour from the outside of the well toward the center, kneading gently until the mass of dough comes together. Knead the dough until it is smooth and resilient. You may need to add more flour, or you may not be able to incorporate all of the flour, depending on the humidity and the size of the eggs. If the dough is sticky or extremely pliable, knead more flour into it./n3. Divide the dough into three portions, cover with plastic wrap or an overturned bowl, and allow to rest for at least 30 minutes./n4. Roll the dough out very thin on a lightly floured surface, one portion at a time. If you have a pasta machine, follow the manufacturer's instructions for rolling out the dough into sheets about 1 millimeter thick. Use as desired.\"," +
                "    \"name\": \"Fresh Pasta\"," +
                "    \"duration\": \"50 mins\"," +
                "    \"difficulty\": \"medium\"," +
                "    \"image\": \"https://null/" +
                "    }" +
                "  ]";
            return rawJson;
        }
    }
}
