using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_MIDTERM_300869273
    {
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
        {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private List<Int32> _elementList;
        private int _elementNumber;
        private List<Int32> _numberList;
        private Random _random;
        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This property reads the _elementList field.
        * </summary>
        *
        * @property ElementList
        */
        public List<Int32> ElementList
            {
            get
                {
                return this._elementList;
                }
            }

        /**<summary>
        * This property reads/writes the _elementNumber field.
        * </summary>
        *
        * @property ElementNumber
        */
        public int ElementNumber
            {
            get
                {
                return this.ElementNumber;
                }
            set
                {
                this.ElementNumber = value;
                }
            }

        /**<summary>
        * This property reads the _numberList field.
        * </summary>
        *
        * @property NumberList
        */
        public List<Int32> NumberList
            {
            get
                {
                return this._numberList;
                }
            }

        /**<summary>
        * This property reads the _random field.
        * </summary>
        *
        * @property random
        */
        public Random random
            {
            get
                {
                return this._random;
                }
            }

        /**<summary>
        * This property reads/writes the _setSize field.
        * </summary>
        *
        * @property SetSize
        */
        public int SetSize
            {
            get
                {
                return this._setSize;
                }
            set
                {
                this._setSize = value;
                }
            }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
            {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
            }



        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
         * This method instantiates new objects for the private fields: _numberList, _elementList, _random.
         * </summary>
         * 
         * @Method _initialize
         * @private
         * @returns {void}
         */
        private void _initialize()
            {
            List<Int32> _numberList = new List<Int32>();
            List<Int32> _elementList = new List<Int32>();
            Random _random = new Random();
            }

        /** <summary>
         * This method Adds Interger Literals from 1 to SetSize to the NumberList property.
         * </summary>
         * 
         * @Method _build
         * @private
         * @returns {void}
         */
        private void _build()
            {
            int count = 0;
            while (count < SetSize)
                {
                this.NumberList.Add(count + 1);
                }
            }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
            {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
                {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
                }

            return lottoNumberString;
            }




        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
         * This method clears and rebuilds the NumberList property if the ElementList property is not empty.
         * </summary>
         *
         * @method PickElements
         * @returns {void}
         */
        public void PickElements()
            {
            if (this.ElementList.Count > 0)
                {
                this.ElementList.Clear();
                this.NumberList.Clear();
                this._build();
                }
            for (int i = 0; i < this.ElementNumber; i++)
                {
                int randomNum = this._random.Next(0, NumberList.Count);
                int temp = this.NumberList[randomNum];
                this.NumberList[randomNum].Remove;

                }
            }
        }
    }
