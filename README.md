# UCCalcWinForms
A personal project that calculates Universal Credit entitlement. this makes it easier to see how a change of circumstances such as income change, or additional child would impact Universal Credit and overall income. I had created a spreadsheet version of this for my own calculations, and felt itd make a good candidate for conversion to an application, providing me with practice reading data from a form, performing calculations, and returning result to the user. the calculation uses conditonal statements such as if and switch, any children are added to a list. a foreach loops is used to iterate through the children. Basic arithmetic is used to calculate entitlement, and the effect income has on entitlement. This project is created using winforms.

these results are not perfect and can return the wrong result due to not taking into account all factors. The benefits system is complex and unrealistic for me to account for every factor in a small personal project. some areas where an incorrect result will be produced are:-

doesn't take into account local housing rates. will assume that universal credit will always pay rent in full. this is not true. fixing this would require local housing rate data that i dont possess.

doesn't take into account exceptions to two child limit. calculation capped at two children. this application is for practice only, and researching exceptions, would take me away from that practicing.

doesn't take into account childcare.

doesn't take into account disabled children.

others issues likely exist.

some of these limitations may represent future areas of improvement.

this project has been developed for my own learning. It should be assumed that i may have made mistakes. Results may be inaccurate. This should not be used for real world Universal Credit claims.
