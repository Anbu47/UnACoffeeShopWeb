import React from "react";
import "../styles/style.css";

const ColdCoffee = () => {
  const sizeOptions = [
    { value: "0", label: "Size S" },
    { value: "1", label: "Size M" },
    { value: "2", label: "Size L" },
    { value: "3", label: "Size XL" },
  ];

  const whippedCreamOptions = [
    { value: "0", label: "No" },
    { value: "1", label: "Yes" },
  ];

  const milkOptions = [
    { value: "0", label: "No" },
    { value: "1", label: "Whole Milk" },
    { value: "2", label: "Almond Milk" },
  ];

  return (
    <>
      <h2>Cold Coffee</h2>
      <div className="iframe-container">
        <iframe
          title="Cold Coffee Recipe"
          src="https://drive.google.com/file/d/19AYIBSD8_vu2Kt71BgosKrR0nD1JhoZy/preview"
          width="640"
          height="480"
          allow="autoplay"
        ></iframe>
      </div>
      <p>Refreshing and chilled beverage perfect for hot weather.</p>
      <p>Item Price: $2.00</p>

      <h2>Options</h2>
      <SizeOptions options={sizeOptions} />
      <WhippedCreamOptions options={whippedCreamOptions} />
      <MilkOptions options={milkOptions} />

      <label htmlFor="notes">Special Instructions:</label>
      <textarea id="notes" name="notes"></textarea>

      <a href="./cart">
        <button type="submit">Add to Cart</button>
      </a>
    </>
  );
};

const SizeOptions = ({ options }) => {
  return (
    <div>
      <label htmlFor="sizeOptions">SIZE: </label>
      <select id="sizeOptions">
        {options.map((option) => (
          <option key={option.value} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>
    </div>
  );
};

const WhippedCreamOptions = ({ options }) => {
  return (
    <div>
      <label htmlFor="whippedCreamOptions">EXTRA WHIPPED CREAM? </label>
      <select id="whippedCreamOptions">
        {options.map((option) => (
          <option key={option.value} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>
    </div>
  );
};

const MilkOptions = ({ options }) => {
  return (
    <div>
      <label htmlFor="milkOptions">EXTRA MILK? </label>
      <select id="milkOptions">
        {options.map((option) => (
          <option key={option.value} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>
    </div>
  );
};

export default ColdCoffee;
