MESSAGE_SHOWN="false"

for (( repo_index=0; repo_index<${#REPO_CHECKOUTS[@]}; repo_index++ )); do
    if [ ! -z "${REPO_CHECKOUTS[$repo_index]}" ]; then
        if [ $MESSAGE_SHOWN = "false" ]; then
            echo ""
            echo "Several custom checkout definitions were detected, as listed below."
            echo ""
            MESSAGE_SHOWN="true"
        fi
        echo "${REPO_NAMES[${repo_index}]} - ${REPO_CHECKOUTS[${repo_index}]}"            
    fi
done

if [ $MESSAGE_SHOWN = "true" ]; then
    echo ""
    while :
    do
        read -p "Do you wish to checkout these repositories in the above specified branches/tags (y), or do you wish to checkout them on their default branches (n)?" checkout_answer
        case $checkout_answer in
            y)
                echo "Very well. Checking out repositories on specified targets..."
                for (( repo_index=0; repo_index<${#REPO_CHECKOUTS[@]}; repo_index++ )); do
                    if [ ! -z "${REPO_CHECKOUTS[$repo_index]}" ]; then
                        REPO_URLS[$repo_index]+=" -b ${REPO_CHECKOUTS[$repo_index]}"
                    fi
                done
                break
                ;;
            n)
                echo "Very well. Checking out repositories on default branch..."
                break
                ;;
            *)
                ;;
        esac
    done
    echo ""
fi
